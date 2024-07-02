package decodethemessage_2325

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestDecodeMessageFirstCase(t *testing.T) {
	key := "the quick brown fox jumps over the lazy dog"
	message := "vkbs bs t suepuv"
	assert.Equal(t, "this is a secret", decodeMessage(key, message))
}

func TestDecodeMessageSecondCase(t *testing.T) {
	key := "eljuxhpwnyrdgtqkviszcfmabo"
	message := "zwx hnfx lqantp mnoeius ycgk vcnjrdb"
	assert.Equal(t, "the five boxing wizards jump quickly", decodeMessage(key, message))
}
