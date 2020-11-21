using System;
using Core.Domain;

namespace Coverage.Domain
{
    public class Document
    {
        public Document(NonEmptyString name, NonEmptyString mimeType)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            MimeType = mimeType ?? throw new ArgumentNullException(nameof(mimeType));
        }

        public bool Archived { get; private set; }

        public string MimeType { get; private set; }

        public string Name { get; private set; }

        public virtual void Archive()
        {
            Archived = true;
        }
    }
}