package number_of_senior_citizens

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test_FirstTest(t *testing.T) {
	details := []string{"7868190130M7522", "5303914400F9211", "9273338290F4010"}

	number := countSeniors(details)

	assert.Equal(t, 2, number)
}

func Test_SecondTest(t *testing.T) {
	details := []string{"1313579440F2036", "2921522980M5644"}

	number := countSeniors(details)

	assert.Equal(t, 0, number)
}
