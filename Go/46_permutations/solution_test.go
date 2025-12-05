package _46_permutations

import (
	"fmt"
	"sort"
	"testing"
)

func Test(t *testing.T) {
	tests := []struct {
		nums []int
		want [][]int
	}{
		{
			nums: []int{1, 2, 3},
			want: [][]int{[]int{1, 2, 3}, []int{1, 3, 2}, []int{2, 1, 3}, []int{2, 3, 1}, []int{3, 1, 2}, []int{3, 2, 1}},
		},
		{
			nums: []int{0, 1},
			want: [][]int{{0, 1}, {1, 0}},
		},
		{
			[]int{1},
			[][]int{{1}},
		},
	}

	for idx, test := range tests {
		t.Run(fmt.Sprintf("Test permutations %d", idx), func(t *testing.T) {
			result := permute(test.nums)

			if !equals(test.want, result) {
				t.Errorf("Test permutations %d failed", idx)
			}
		})
	}
}

func TestEqualsTwoJagedArray(t *testing.T) {
	tests := []struct {
		first    [][]int
		second   [][]int
		expected bool
	}{
		{[][]int{{0, 1}, {1, 0}}, [][]int{{1, 0}, {0, 1}}, true}}

	for idx, test := range tests {
		t.Run(fmt.Sprintf("Test %d", idx), func(t *testing.T) {
			result := equals(test.first, test.second)

			if result != test.expected {
				t.Failed()
			}
		})
	}
}

func equals(a [][]int, b [][]int) bool {
	if len(a) != len(b) {
		return false
	}

	normalize(a)
	normalize(b)

	for i := range a {
		if len(a[i]) != len(b[i]) {
			return false
		}
		for j := range a[i] {
			if a[i][j] != b[i][j] {
				return false
			}
		}
	}

	return true
}

func normalize(a [][]int) {
	// 2. Сортируем внешний массив, сравнивая подмассивы лексикографически
	sort.Slice(a, func(i, j int) bool {
		ai, aj := a[i], a[j]

		// сравнение поэлементно
		for k := 0; k < len(ai) && k < len(aj); k++ {
			if ai[k] != aj[k] {
				return ai[k] < aj[k]
			}
		}

		// Если один — префикс другого, более короткий — меньше
		return len(ai) < len(aj)
	})
}
