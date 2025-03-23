using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Services.Client;
using System.Linq;
using System.Text;

namespace Utilities.Clases.BindingList
{
    public class MyBindingList<T> : BindingList<T>
    {
        private DataServiceContext context = null;

        private string objectName;

        public MyBindingList()
            : base()
        { }


        public MyBindingList(IList<T> obj)
            : base(obj)
        {
        }

        public MyBindingList(IList<T> obj, DataServiceContext Context, string ObjectName)
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
                        context.AddObject(objectName, this[e.NewIndex]);
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
                context.DeleteObject(this[index]);
            }

            base.RemoveItem(index);
        }
    }


}
