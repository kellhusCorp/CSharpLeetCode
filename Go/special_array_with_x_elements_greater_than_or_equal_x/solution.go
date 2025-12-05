package special_array_with_x_elements_greater_than_or_equal_x

func specialArray(nums []int) (result int) {

	results := make([]int, len(nums)+1)
	for i := 0; i <= len(nums); i++ {
		results[i] = i
	}
	for _, value := range results {
		counter := 0
		for _, num := range nums {
			if num >= value {
				counter++
			}
		}

		if counter == value {
			return counter
		}
	}

	return -1
}
