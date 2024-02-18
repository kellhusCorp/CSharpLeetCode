package happy_number_202

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestIsHappyReturnsTrueWhenNumberEquals19(t *testing.T) {
	number := 19
	result := isHappy(number)
	assert.Equal(t, true, result)
}

func TestIsHappyReturnsFalseWhenNumberEquals2(t *testing.T) {
	number := 2
	result := isHappy(number)
	assert.Equal(t, false, result)
}
