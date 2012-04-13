namespace System.Data.Entity.Core.Mapping
{
    /// <summary>
    /// Attribute to mark the assemblies that contain the generated views type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class EntityViewGenerationAttribute : Attribute
    {
        #region Constructors

        /// <summary>
        /// Constructor for EntityViewGenerationAttribute
        /// </summary>
        public EntityViewGenerationAttribute(Type viewGenerationType)
        {
            EntityUtil.CheckArgumentNull(viewGenerationType, "viewGenType");
            m_viewGenType = viewGenerationType;
        }

        #endregion

        #region Fields

        private readonly Type m_viewGenType;

        #endregion

        #region Properties

        public Type ViewGenerationType
        {
            get { return m_viewGenType; }
        }

        #endregion
    }
}