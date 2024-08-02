package find_original_array_of_prefix_xor_2433

func findArray(pref []int) []int {
	for i := len(pref) - 1; i > 0; i-- {
		pref[i] = pref[i-1] ^ pref[i]
	}

	return pref
}
