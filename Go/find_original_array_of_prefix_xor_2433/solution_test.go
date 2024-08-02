package find_original_array_of_prefix_xor_2433

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestFirstCase(t *testing.T) {
	pref := []int{5, 2, 0, 3, 1}
	expected := []int{5, 7, 2, 3, 2}
	actual := findArray(pref)

	assert.EqualValues(t, expected, actual)
}

func TestSecondCase(t *testing.T) {
	pref := []int{13}
	expected := []int{13}
	actual := findArray(pref)

	assert.EqualValues(t, expected, actual)
}
