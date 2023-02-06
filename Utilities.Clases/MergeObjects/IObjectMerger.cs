using System.Collections.Generic;

namespace Utilities.Clases.MergeObjects
{
    public interface IObjectMerger
    {
        MergeOptions mergeOptions { get; set; }

        List<PropMerge> Compare();
        List<PropMerge> Compare(object objX, object objY);
        object MergeObjects();
    }
}