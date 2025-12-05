package special_array_with_x_elements_greater_than_or_equal_x

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test_SpecialArray_FirstCase(t *testing.T) {
	arr := []int{3, 5}

	actual := specialArray(arr)

	assert.Equal(t, 2, actual)
}

func Test_SpecialArray_LastCase(t *testing.T) {
	arr := []int{0, 0}

	actual := specialArray(arr)

	assert.Equal(t, -1, actual)
}
