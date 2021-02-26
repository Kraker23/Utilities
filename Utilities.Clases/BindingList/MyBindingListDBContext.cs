using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Services.Client;
using System.Linq;
using System.Text;

namespace Utilities.Clases.BindingList
{
    public class MyBindingListDBContext<T> : BindingList<T>
    {
        private DbContext context = null;

        private string objectName;

        public MyBindingListDBContext()
            : base()
        { }


        public MyBindingListDBContext(IList<T> obj, DbContext Context, string ObjectName)
            : base(obj)
        {
            context = Context;
            objectName = ObjectName;
        }


        protected override void OnListChanged(ListChangedEventArgs e)
        {
            try
            {
                

                base.OnListChanged(e);

                if (context != null)
                {
                    if (e.ListChangedType == ListChangedType.ItemAdded)
                    {
                        context.Set(this[e.NewIndex].GetType()).Add(this[e.NewIndex]);
                    }
                }
            }
            catch
            { }
        }


        protected override void OnAddingNew(AddingNewEventArgs e)
        {
            base.OnAddingNew(e);
        }


        protected override void RemoveItem(int index)
        {
            if (context != null && this.Count > index)
            {
                context.Set(this[index].GetType()).Remove(this[index]);
            }

            base.RemoveItem(index);
        }
    }


}
