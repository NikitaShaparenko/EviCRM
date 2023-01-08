using EviCRM.Core.Db.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace EviCRM.Core.Db.Entities.Alexandra
{
    public class Poll : IMetaFiller
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Пояснения к вопросу
        /// </summary>
        public string? Explanations { get; set; }

        /// <summary>
        /// Флаг "Разрешить мультивыбор ответов?"
        /// </summary>
        public bool IsMultipleAnswers { get; set; }

        /// <summary>
        /// Флаг анонимности опроса
        /// </summary>
        public bool IsAnon { get; set; }
        
        /// <summary>
        /// Флаг активности опроса
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// JSON c вариантами ответов
        /// </summary>
        [Column(TypeName = "jsonb")]
        public string? MultipleAnswers { get; set; }

        /// <summary>
        /// Опции опроса
        /// </summary>
        public string? Options { get; set; }

        /// <summary>
        /// Тип опроса
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Корректный ответ 
        /// </summary>
        public string CorrectOptionId { get; set; }

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
