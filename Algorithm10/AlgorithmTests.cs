using NUnit.Framework;

namespace Algorithm10
{
    public class Tests
    {
        private int[] Algorithm(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;

            int i = 0, j = 0, k = 0;
            Array.Sort(nums1);
            Array.Sort(nums2);

            while (i < length1 && j < length2)
            {
                if (nums1[i] < nums2[j]) {
                    i++;
                }
                else if (nums1[i] > nums2[j]) {
                    j++;
                }
                else
                {
                    nums1[k++] = nums1[i++];
                    j++;
                }
            }

            var result = new int[k];
            Array.Copy(nums1, result, k);

            return result;
        }

        #region Tests
        [Test]
        public void Test1()
        {
            // Arrange
            var testArray1 = new int[] { 1, 2, 2, 1 };
            var testArray2 = new int[] { 2, 2 };
            var expectedResult = new int[] { 2, 2 };

            // Act
            var result = Algorithm(testArray1, testArray2);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var testArray1 = new int[] { 4, 9, 5 };
            var testArray2 = new int[] { 9, 4, 9, 8, 4 };
            var expectedResult = new int[] { 4, 9 };

            // Act
            var result = Algorithm(testArray1, testArray2);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        #endregion
    }
}