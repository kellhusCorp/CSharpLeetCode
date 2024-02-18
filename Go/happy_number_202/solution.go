package happy_number_202

func isHappy(n int) bool {
	m := map[int]int{}

	for n != 1 {
		n = getSumOfSquares(getDigits(n))
		_, ok := m[n]
		if ok {
			return false
		}

		m[n] = 0
	}

	return true
}

func getSumOfSquares(arr []int) int {
	sum := 0
	for _, value := range arr {
		sum += value * value
	}

	return sum
}

func getDigits(n int) []int {
	var result []int
	for n != 0 {
		result = append(result, n%10)
		n /= 10
	}

	return result
}
