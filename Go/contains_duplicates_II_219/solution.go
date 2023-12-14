package contains_duplicates_II_219

import "math"

func containsNearbyDuplicate(nums []int, k int) bool {
	m := map[int]int{}

	for i := 0; i < len(nums); i++ {
		j, ok := m[nums[i]]
		if !ok {
			m[nums[i]] = i
		} else {
			if math.Abs(float64(i-j)) <= float64(k) {
				return true
			}

			m[nums[i]] = i
		}
	}

	return false
}
