package decodethemessage_2325

import (
	"strings"
)

var (
	appearance map[rune]rune
	english    map[rune]int
)

func decodeMessage(key string, message string) string {
	english = make(map[rune]int)
	appearance = make(map[rune]rune)
	for i, letter := 1, 97; i <= 26; i, letter = i+1, letter+1 {
		english[rune(i)] = letter
	}

	var uniqueIndex = 1

	for _, letter := range key {
		if letter == ' ' {
			continue
		}
		_, ok := appearance[letter]
		if !ok {
			appearance[letter] = rune(english[rune(uniqueIndex)])
			uniqueIndex++
		}
	}

	var sb strings.Builder

	for _, letter := range message {
		if letter == ' ' {
			sb.WriteRune(' ')
			continue
		}
		sb.WriteRune(appearance[letter])
	}

	return sb.String()
}
