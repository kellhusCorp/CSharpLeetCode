package counting_elements_1426

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test_countElements_FirstCase(t *testing.T) {
	arr := []int{1, 2, 3}

	result := countElements(arr)

	assert.Equal(t, 2, result)
}
