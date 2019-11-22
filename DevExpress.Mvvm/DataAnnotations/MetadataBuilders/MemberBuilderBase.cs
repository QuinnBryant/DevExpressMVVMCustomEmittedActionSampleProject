using DevExpress.Mvvm.Native;
using System;
using System.Collections.Generic;

namespace DevExpress.Mvvm.DataAnnotations {
    public abstract class MemberMetadataBuilderBase<T, TBuilder, TParent> :
        IPropertyMetadataBuilder, IAttributeBuilderInternal, IAttributeBuilderInternal<TBuilder>
        where TBuilder : MemberMetadataBuilderBase<T, TBuilder, TParent>
        where TParent : MetadataBuilderBase<T, TParent> {

        readonly MemberMetadataStorage storage;
        protected internal readonly TParent parent;

        internal MemberMetadataBuilderBase(MemberMetadataStorage storage, TParent parent) {
            this.storage = storage;
            this.parent = parent;
        }
        internal TBuilder AddOrModifyAttribute<TAttribute>(Action<TAttribute> setAttributeValue = null) where TAttribute : Attribute, new() {
            storage.AddOrModifyAttribute(setAttributeValue);
            return (TBuilder)this;
        }
        internal TBuilder AddOrReplaceAttribute<TAttribute>(TAttribute attribute) where TAttribute : Attribute {
            storage.AddOrReplaceAttribute(attribute);
            return (TBuilder)this;
        }
        TBuilder IAttributeBuilderInternal<TBuilder>.AddOrReplaceAttribute<TAttribute>(TAttribute attribute) {
            return AddOrReplaceAttribute(attribute);
        }
        TBuilder IAttributeBuilderInternal<TBuilder>.AddOrModifyAttribute<TAttribute>(Action<TAttribute> setAttributeValue) {
            return AddOrModifyAttribute(setAttributeValue);
        }
        void IAttributeBuilderInternal.AddOrReplaceAttribute<TAttribute>(TAttribute attribute) {
            AddOrReplaceAttribute(attribute);
        }
        void IAttributeBuilderInternal.AddOrModifyAttribute<TAttribute>(Action<TAttribute> setAttributeValue) {
            AddOrModifyAttribute(setAttributeValue);
        }
        internal TBuilder AddAttribute(Attribute attribute) {
            storage.AddAttribute(attribute);
            return (TBuilder)this;
        }
        IEnumerable<Attribute> IPropertyMetadataBuilder.Attributes {
            get { return storage.GetAttributes(); }
        }

        protected TBuilder DisplayNameCore(string name) {
            return DataAnnotationsAttributeHelper.DisplayNameCore((TBuilder)this, name);
        }
        protected TBuilder DisplayShortNameCore(string shortName) {
            return DataAnnotationsAttributeHelper.DisplayShortNameCore((TBuilder)this, shortName);
        }
        protected TBuilder DescriptionCore(string description) {
            return DataAnnotationsAttributeHelper.DescriptionCore((TBuilder)this, description);
        }
        protected TBuilder NotAutoGeneratedCore() {
            return DataAnnotationsAttributeHelper.AutoGeneratedCore((TBuilder)this, false);
        }
        protected TBuilder AutoGeneratedCore() {
            return DataAnnotationsAttributeHelper.AutoGeneratedCore((TBuilder)this, true);
        }
        protected TBuilder ImageUriCore(string imageUri) {
            return AddOrModifyAttribute<ImageAttribute>(x => x.ImageUri = imageUri);
        }
    }
}