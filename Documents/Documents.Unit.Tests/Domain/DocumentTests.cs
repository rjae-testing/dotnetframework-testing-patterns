using System;
using Documents.Domain;
using Xunit;

namespace Documents.Unit.Tests.Domain
{
    public class DocumentTests
    {
        [Fact]
        public void ConstructorMustThrowExceptionWhenMimeTypeIsNull()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => new Document("test.txt", null));
            Assert.Equal($"Value cannot be null.{Environment.NewLine}Parameter name: mimeType", exception.Message);
        }

        [Fact]
        public void ConstructorMustThrowExceptionWhenNameIsNull()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => new Document(null, null));
            Assert.Equal($"Value cannot be null.{Environment.NewLine}Parameter name: name", exception.Message);
        }

        [Fact]
        public void PropertiesMustReturnExpectedValuesWhenSet()
        {
            Document document = new Document("test.txt", "test/test");
            Assert.Equal("test.txt", document.Name);
            Assert.Equal("test/test", document.MimeType);
            Assert.False(document.Archived);
            document.Archive();
            Assert.True(document.Archived);
        }
    }
}