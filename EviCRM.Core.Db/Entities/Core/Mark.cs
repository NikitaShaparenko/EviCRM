using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EviCRM.Core.Db.Entities.Core
{
    public class Mark : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Пользователь, поставивший оценку
        /// </summary>
        public User WhoSet { get; set; }

        /// <summary>
        /// Пользователь, кому поставили оценку
        /// </summary>
        public User WhoReceive { get; set; }

        /// <summary>
        /// Когда была добавлена запись
        /// </summary>
        public DateTime? WhenFirstMarkInserted { get; set; }

        /// <summary>
        /// Когда была обновлена запись
        /// </summary>
        public DateTime? WhenFirstMarkUpdated { get; set; }

        /// <summary>
        /// Кто добавил запись
        /// </summary>
        public Guid? WhoFirstMarkInserted { get; set; }

        /// <summary>
        /// Кто отредактировал запись
        /// </summary>
        public Guid? WhoFirstMarkUpdated { get; set; }

        /// <summary>
        /// Когда была добавлена запись
        /// </summary>
        public DateTime? WhenSecondMarkInserted { get; set; }

        /// <summary>
        /// Когда была обновлена запись
        /// </summary>
        public DateTime? WhenSecondMarkUpdated { get; set; }

        /// <summary>
        /// Кто добавил запись
        /// </summary>
        public Guid? WhoSecondMarkInserted { get; set; }

        /// <summary>
        /// Кто отредактировал запись
        /// </summary>
        public Guid? WhoSecondMarkUpdated { get; set; }

        /// <summary>
        /// Первая оценка
        /// </summary>
        public uint? FirstMark { get; set; }

        /// <summary>
        /// Вторая оценка
        /// </summary>
        public uint? SecondMark { get; set; }

        /// <summary>
        /// Описание первой оценки
        /// </summary>
        public string? FirstDescription { get; set; }

        /// <summary>
        /// Описание второй оценки
        /// </summary>
        public string? SecondDescription { get; set; }

        /// <summary>
        /// Список вложений к первой оценке
        /// </summary>
        public List<Guid>? FirstAttachments { get; set; }

        /// <summary>
        /// Список вложений ко второй оценке
        /// </summary>
        public List<Guid>? SecondAttachments { get; set; }

        /// <summary>
        /// Флаг "Установлено 2 оценки"
        /// </summary>
        public bool isTwoMarks { get; set; }

        /// <summary>
        /// Флаг "Нет оценкок"
        /// </summary>
        public bool isNoMarks { get; set; }

        /// <summary>
        /// Когда была добавлена запись
        /// </summary>
        public DateTime? WhenInserted { get; set; }

        /// <summary>
        /// Когда была обновлена запись
        /// </summary>
        public DateTime? WhenUpdated { get; set; }

        /// <summary>
        /// Кто добавил запись
        /// </summary>
        public Guid? WhoInserted { get; set; }

        /// <summary>
        /// Кто отредактировал запись
        /// </summary>
        public Guid? WhoUpdated { get; set; }


    }
}
