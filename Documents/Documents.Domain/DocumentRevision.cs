﻿using Core.Domain;

namespace Coverage.Domain
{
    public class DocumentRevision : Document
    {
        public DocumentRevision(NonEmptyString name, NonEmptyString mimeType) : base(name, mimeType)
        {
        }

        public bool Approved { get; private set; }

        public virtual void Approve()
        {
            Approved = true;
        }
    }
}