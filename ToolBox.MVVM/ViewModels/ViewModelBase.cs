using System;
using System.Collections.Generic;
using System.Text;

namespace ToolBox.MVVM.ViewModels
{
    public abstract class ViewModelBase : ObservableObject
    {
    }
    
    public abstract class ViewModelBase<TEntity> : ViewModelBase
        where TEntity : class
    {
        protected TEntity Entity { get; private set; }

        protected ViewModelBase(TEntity entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            Entity = entity;
        }
    }
}
