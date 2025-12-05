package _46_permutations

func getMap(nums []int) map[int]int {
	m := make(map[int]int)

	for _, v := range nums {
		if _, ok := m[v]; !ok {
			m[v] = 1
		} else {
			m[v]++
		}
	}

	return m
}

func permute(nums []int) [][]int {
	m := getMap(nums)

	var res [][]int

	dfs(m, make([]int, 0), &res, len(nums))

	return res
}

func dfs(m map[int]int, arr []int, result *[][]int, length int) {
	if len(arr) == length {
		tmp := make([]int, len(arr))
		copy(tmp, arr)
		*result = append(*result, tmp)
		return
	}
	for k := range m {
		if m[k] == 0 {
			continue
		}
		m[k]--
		arr = append(arr, k)
		dfs(m, arr, result, length)
		arr = arr[:len(arr)-1]
		m[k]++
	}
}
