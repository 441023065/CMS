using System;
namespace AtomLab.Domain
{
    /// <summary>
    /// ���������¼������ӿ�.
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    public interface IEventHandler<TEvent> where TEvent : IEvent
    {
        void Handle(TEvent evnt);
    }

    /// <summary>
    /// ���������¼������ӿ�.(��ʵ�ֵõ�������󷽷�GetEntityId)
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    public interface IEntityEventHandler<TEvent> : IEventHandler<TEvent> where TEvent : IEvent
    {
        object GetEntityId(TEvent evnt);
    }
}
