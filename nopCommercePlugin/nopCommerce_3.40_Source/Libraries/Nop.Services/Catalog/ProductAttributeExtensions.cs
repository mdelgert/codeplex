
using Nop.Core.Domain.Catalog;

namespace Nop.Services.Catalog
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ProductAttributeExtensions
    {
        /// <summary>
        /// A value indicating whether this product variant attribute should have values
        /// </summary>
        /// <param name="productVariantAttribute">Product variant attribute</param>
        /// <returns>Result</returns>
        public static bool ShouldHaveValues(this ProductVariantAttribute productVariantAttribute)
        {
            if (productVariantAttribute == null)
                return false;

            if (productVariantAttribute.AttributeControlType == AttributeControlType.TextBox ||
                productVariantAttribute.AttributeControlType == AttributeControlType.MultilineTextbox ||
                productVariantAttribute.AttributeControlType == AttributeControlType.Datepicker || 
                productVariantAttribute.AttributeControlType == AttributeControlType.FileUpload)
                return false;

            //other attribute controle types support values
            return true;
        }

        /// <summary>
        /// A value indicating whether this product variant attribute should can have some validation rules
        /// </summary>
        /// <param name="productVariantAttribute">Product variant attribute</param>
        /// <returns>Result</returns>
        public static bool ValidationRulesAllowed(this ProductVariantAttribute productVariantAttribute)
        {
            if (productVariantAttribute == null)
                return false;

            if (productVariantAttribute.AttributeControlType == AttributeControlType.TextBox ||
                productVariantAttribute.AttributeControlType == AttributeControlType.MultilineTextbox ||
                productVariantAttribute.AttributeControlType == AttributeControlType.FileUpload)
                return true;

            //other attribute controle types does not have validation
            return false;
        }
    }
}
