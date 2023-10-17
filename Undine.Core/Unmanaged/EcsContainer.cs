using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Core.Unmanaged
{
    public abstract class EcsContainer : IEcsContainer
    {
        protected Dictionary<Type, Action<object, IUnifiedEntity>> _actions = new Dictionary<Type, Action<object, IUnifiedEntity>>();

        public virtual void RegisterComponentType<A>(Action<object, IUnifiedEntity> action = null)
            where A : unmanaged
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
        where A : unmanaged;

        public abstract void AddSystem<A, B>(UnifiedSystem<A, B> system)
        where A : unmanaged
        where B : unmanaged;

        public abstract void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged;

        public abstract void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
        where D : unmanaged;

        public abstract ISystem GetSystem<A>(UnifiedSystem<A> system)
        where A : unmanaged;

        public abstract ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        where A : unmanaged
        where B : unmanaged;

        public abstract ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged;

        public abstract ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : unmanaged
        where B : unmanaged
        where C : unmanaged
        where D : unmanaged;

        public virtual void Init()
        {
        }

        public abstract void Run();

        public abstract IUnifiedEntity CreateNewEntity();
    }
}