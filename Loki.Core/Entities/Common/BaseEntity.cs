namespace Loki.Core.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateModified { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset? DateDeleted { get; set; }

        public bool IsDeleted { get; set; }

        public void Delete()
        {
            if (IsDeleted) return;

            IsDeleted = true;
            DateDeleted = DateTimeOffset.UtcNow;
            DateModified = DateTimeOffset.UtcNow;
        }
    }
}
