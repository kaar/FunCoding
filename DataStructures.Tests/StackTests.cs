using System;
using Xunit;

namespace DataStructures.Tests {
    public class StackTests {
        [Fact]
        public void Push() {
            var s = new Stack<int>();

            // Act
            s.Push(1);
            int val = s.Pop();

            // Assert
            Assert.Equal(1, val);
        }

        [Fact]
        public void PushPop_Twice_() {
            // Act
            var s = new Stack<int>();
            s.Push(1);
            s.Push(2);

            // Assert
            Assert.Equal(2, s.Pop());
            Assert.Equal(1, s.Pop());
        }

        [Fact]
        public void Pop_OnEmptyStack() {
            // Act
            var s = new Stack<int>();

            // Act
            try {
                s.Pop();
            } catch (Exception e) {
                Assert.Equal("Stack is empty", e.Message);
            }
        }

        [Fact]
        public void Push_BeyondStackSize_ResizeStack() {
            var s = new Stack<int>(2);

            // Act
            s.Push(1);
            s.Push(2);
            s.Push(3);

            // Assert
            s.Pop();
            s.Pop();
            Assert.Equal(1, s.Pop());
        }

        [Fact]
        public void IsEmpty_OnEmptyStack_ReturnTrue() {
            // Arrange
            var s = new Stack<int>();

            // Act
            bool actual = s.IsEmpty();

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void IsEmpty_OnStackWithValies_ReturnFalse() {
            // Arrange
            var s = new Stack<int>();
            s.Push(1);

            // Act
            bool actual = s.IsEmpty();

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void Size_OnEmptyStack_Return0() {
            // Arrange
            var s = new Stack<int>();

            // Act
            int actual = s.Size();

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Size_OnWithValues_Return() {
            // Arrange
            var s = new Stack<int>();
            s.Push(1);

            // Act
            int actual = s.Size();

            // Assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void CreateStackWithNegativeSize() {
            // Act
            try {
                var stack = new Stack<int>(-1);
            } catch (Exception e) {
                Assert.Equal("Stack size can not be less then 0.", e.Message);
            }
            
        }
    }
}
