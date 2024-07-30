package counting_elements_1426

func countElements(arr []int) int {
	d := make(map[int]int)

	counter := 0

	for _, value := range arr {
		d[value] = value
	}

	for _, value := range arr {
		if _, ok := d[value+1]; ok {
			counter++
		}
	}

	return counter
}
