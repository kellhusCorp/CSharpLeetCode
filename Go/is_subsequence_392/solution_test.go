package is_subsequence_392

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test_IsSubsequence392(t *testing.T) {
	s := "abc"
	testStr := "ahbgdc"
	expected := true

	actual := isSubsequence(s, testStr)

	assert.Equal(t, expected, actual)
}
