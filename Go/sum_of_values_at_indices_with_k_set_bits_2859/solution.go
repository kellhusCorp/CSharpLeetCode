package sum_of_values_at_indices_with_k_set_bits_2859

func sumIndicesWithKSetBits(nums []int, k int) (sum int) {
	for idx, value := range nums {
		if getNumberOfBits(idx) == k {
			sum += value
		}
	}

	return sum
}

func getNumberOfBits(number int) (counter int) {
	for ; number > 0; number >>= 1 {
		counter += number & 1
	}

	return counter
}
