using Documents.Domain;
using Xunit;

namespace Documents.Unit.Tests.Domain
{
    public class DocumentRevisionTests
    {
        [Fact]
        public void PropertiesMustReturnExpectedValuesWhenSet()
        {
            DocumentRevision revision = new DocumentRevision("test.txt", "test/test");
            Assert.False(revision.Approved);
            revision.Approve();
            Assert.True(revision.Approved);
        }
    }
}