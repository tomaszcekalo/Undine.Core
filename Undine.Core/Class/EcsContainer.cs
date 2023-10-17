using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Class
{
    public abstract class EcsContainer : IEcsContainer
    {
        protected Dictionary<Type, Action<object, IUnifiedEntity>> _actions = new Dictionary<Type, Action<object, IUnifiedEntity>>();

        public virtual void RegisterComponentType<A>(Action<object, IUnifiedEntity> action = null)
            where A : class
        {
            if (!_actions.ContainsKey(typeof(A)))
            {
                if (action == null)
                {
                    action = (component, entity) => entity.AddComponent((A)component);
                }
                _actions[typeof(A)] = action;
            }
        }

        public virtual void LoadEntitiesFromEditor(List<EditorEntity> entities)
        {
            foreach (var editorEntity in entities)
            {
                var entity = CreateNewEntity();
                foreach (var item in editorEntity.Components)
                {
                    _actions[item.Key].Invoke(item, entity);
                }
            }
        }

        public abstract void AddSystem<A>(UnifiedSystem<A> system)
        where A : class;

        public abstract void AddSystem<A, B>(UnifiedSystem<A, B> system)
        where A : class
        where B : class;

        public abstract void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : class
        where B : class
        where C : class;

        public abstract void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : class
        where B : class
        where C : class
        where D : class;

        public abstract ISystem GetSystem<A>(UnifiedSystem<A> system)
        where A : class;

        public abstract ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        where A : class
        where B : class;

        public abstract ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : class
        where B : class
        where C : class;

        public abstract ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : class
        where B : class
        where C : class
        where D : class;

        public virtual void Init()
        {
        }

        public abstract void Run();

        public abstract IUnifiedEntity CreateNewEntity();
    }
}