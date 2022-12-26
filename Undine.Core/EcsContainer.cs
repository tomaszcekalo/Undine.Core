using System;
using System.Collections.Generic;

namespace Undine.Core
{
    public abstract class EcsContainer : IEcsContainer
    {
        private Dictionary<Type, Action<object, IUnifiedEntity>> _actions = new Dictionary<Type, Action<object, IUnifiedEntity>>();

        public virtual void RegisterComponentType<A>(Action<object, IUnifiedEntity> action = null)
            where A : struct
        {
            if (action == null)
            {
                action = (component, entity) => entity.AddComponent((A)component);
            }
            _actions[typeof(A)] = action;
        }

        public virtual void LoadEntitiesFromEditor(List<EditorEntity> entities)
        {
            foreach (var editorEntity in entities)
            {
                var entity = this.CreateNewEntity();
                foreach (var item in editorEntity.Components)
                {
                    _actions[item.Key].Invoke(item, entity);
                }
            }
        }

        public abstract void AddSystem<A>(UnifiedSystem<A> system)
        where A : struct;

        public abstract void AddSystem<A, B>(UnifiedSystem<A, B> system)
        where A : struct
        where B : struct;

        public abstract void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : struct
        where B : struct
        where C : struct;

        public abstract void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : struct
        where B : struct
        where C : struct
        where D : struct;

        public abstract ISystem GetSystem<A>(UnifiedSystem<A> system)
        where A : struct;

        public abstract ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        where A : struct
        where B : struct;

        public abstract ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        where A : struct
        where B : struct
        where C : struct;

        public abstract ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        where A : struct
        where B : struct
        where C : struct
        where D : struct;

        public virtual void Init()
        {
        }

        public abstract void Run();

        public abstract IUnifiedEntity CreateNewEntity();
    }
}