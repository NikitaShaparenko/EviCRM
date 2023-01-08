﻿namespace EviCRM.Core.Db.Models
{
    public enum ToScriptCommandEnum
    {
        Create, //Создать задачу
        AddDivision, //Добавить к задаче отдел
        AddMember, //Добавить к задаче пользователя
        Notify, //Отправить уведомление участникам задачи
        Fail, //Закрыть задачу владельцем\\администратором\\создателем как провальную
        CompleteBeforeHead, //Завершить задачу заблаговременно
        CompleteDelay, //Завершить задачу с задержкой
        Revision, //Отправить задачу на доработку
        Message, //Опубликовать информацию о сообщении в задаче
        Question, //Опубликовать информацию о вопросе в задаче
        Warning, //Опубликовать информацию о предупреждении в задаче
        Canceled, //Отменить задачу владельцем\\администратором\\создателем
        Roger, //Подтвердить факт приступления к задаче
        Pause, //Поставить владельцем\\администратором\\создателем задачу на паузу
        QA, //Оставить обратную связь о задаче
        Conclusion, //Владельцем\\администратором\\создателем оставить обратную связь о задаче
        KillMember, //Исключить пользователя из задачи
        KillDivision, //Исключить отдел из задачи
        ChangeDeadline, //Изменить конечный срок выполнеиня задачи
        ChangeStartDate, //Изменить начальный срок выполнения задачи
        SendAttachments, //Приложить файл к задаче

        //Отказ от выполнения задачи
        Refuse_NotMe, //По причине: не связана со мной
        Refuse_Impossible, //По причине: считаю задачу невозможной
        Refuse_NoWay, //По причине: не согласен с условиями
        
        //Запрос переноса сроков исполнения задачи
        Delay_OtherTask, //По причине: Наслоение других задач
        Delay_LackTime, //По причине: недостаток времени
        Delay_Forcem, //По причине: форс-мажор
        Delay_NoMoney, //По причине: не хватает финансирования
        Delay_GuiltyMember, //По причине: виноват другой исполнитель
        Delay_Other, //По причине: другое
    }
}