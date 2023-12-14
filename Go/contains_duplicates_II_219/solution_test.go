package contains_duplicates_II_219

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test_ContainsNearbyDuplicate_FirstCase(t *testing.T) {
	nums := []int{1, 2, 3, 1}
	var k = 3
	expected := true

	actual := containsNearbyDuplicate(nums, k)

	assert.Equal(t, expected, actual)
}

func Test_ContainsNearbyDuplicate_SecondCase(t *testing.T) {
	nums := []int{1, 0, 1, 1}
	var k = 1
	expected := true

	actual := containsNearbyDuplicate(nums, k)

	assert.Equal(t, expected, actual)
}

func Test_ContainsNearbyDuplicate_ThirdCase(t *testing.T) {
	nums := []int{1, 2, 3, 1, 2, 3}
	var k = 2
	expected := false

	actual := containsNearbyDuplicate(nums, k)

	assert.Equal(t, expected, actual)
}
