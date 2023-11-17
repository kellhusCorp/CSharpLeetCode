package is_subsequence_392

func isSubsequence(s string, t string) bool {
	var first = 0
	var second = 0

	for first < len(s) && second < len(t) {
		if s[first] == t[second] {
			first++
		}

		second++
	}

	return first == len(s)
}
