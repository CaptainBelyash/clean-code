﻿namespace Markdown.Tag.SpecificTags
{
    public class HeaderTagData : TagData
    {
        public HeaderTagData(TagBorder incomingBorder, TagBorder outgoingBorder,
            params ITagData[] notAllowedNestedTags)
            : base(incomingBorder, outgoingBorder, 
                EndOfLineAction.Complete, notAllowedNestedTags)
        { }

        public override bool IsValid(string data, int startPos, int endPos)
        {
            return startPos == 0 || data[startPos - 1] == '\n';
        }
    }
}