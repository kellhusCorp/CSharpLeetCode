package number_of_senior_citizens

func countSeniors(details []string) int {
	counter := 0
	for _, value := range details {
		ten := value[11]
		ones := value[12]
		if ten > 0x36 || (ten == 0x36 && ones > 0x30) {
			counter++
		}
	}

	return counter
}
