﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace OpenLibrary
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace OpenLibrary.OpenLibrary_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[11];
            _typeNameTable[0] = "OpenLibrary.MainPageData";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "System.Collections.ObjectModel.ObservableCollection`1<OpenLibrary.BookModel>";
            _typeNameTable[3] = "System.Collections.ObjectModel.Collection`1<OpenLibrary.BookModel>";
            _typeNameTable[4] = "OpenLibrary.BookModel";
            _typeNameTable[5] = "String";
            _typeNameTable[6] = "Int32";
            _typeNameTable[7] = "OpenLibrary.DetailsPage";
            _typeNameTable[8] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[9] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[10] = "OpenLibrary.MainPage";

            _typeTable = new global::System.Type[11];
            _typeTable[0] = typeof(global::OpenLibrary.MainPageData);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::OpenLibrary.BookModel>);
            _typeTable[3] = typeof(global::System.Collections.ObjectModel.Collection<global::OpenLibrary.BookModel>);
            _typeTable[4] = typeof(global::OpenLibrary.BookModel);
            _typeTable[5] = typeof(global::System.String);
            _typeTable[6] = typeof(global::System.Int32);
            _typeTable[7] = typeof(global::OpenLibrary.DetailsPage);
            _typeTable[8] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[10] = typeof(global::OpenLibrary.MainPage);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_MainPageData() { return new global::OpenLibrary.MainPageData(); }
        private object Activate_2_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::OpenLibrary.BookModel>(); }
        private object Activate_3_Collection() { return new global::System.Collections.ObjectModel.Collection<global::OpenLibrary.BookModel>(); }
        private object Activate_4_BookModel() { return new global::OpenLibrary.BookModel(); }
        private object Activate_7_DetailsPage() { return new global::OpenLibrary.DetailsPage(); }
        private object Activate_10_MainPage() { return new global::OpenLibrary.MainPage(); }
        private void VectorAdd_2_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::OpenLibrary.BookModel>)instance;
            var newItem = (global::OpenLibrary.BookModel)item;
            collection.Add(newItem);
        }
        private void VectorAdd_3_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::OpenLibrary.BookModel>)instance;
            var newItem = (global::OpenLibrary.BookModel)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  OpenLibrary.MainPageData
                userType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_MainPageData;
                userType.AddMemberName("Books");
                userType.AddMemberName("searchTerm");
                userType.AddMemberName("displayTitle");
                userType.AddMemberName("firstPublishedYear");
                userType.AddMemberName("bookAuthorName");
                userType.AddMemberName("bookCoverImage");
                userType.AddMemberName("SelectedBook");
                userType.AddMemberName("Filter");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  System.Collections.ObjectModel.ObservableCollection`1<OpenLibrary.BookModel>
                userType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<OpenLibrary.BookModel>"));
                userType.CollectionAdd = VectorAdd_2_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 3:   //  System.Collections.ObjectModel.Collection`1<OpenLibrary.BookModel>
                userType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_3_Collection;
                userType.CollectionAdd = VectorAdd_3_Collection;
                xamlType = userType;
                break;

            case 4:   //  OpenLibrary.BookModel
                userType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_4_BookModel;
                userType.AddMemberName("title_suggest");
                userType.AddMemberName("first_publish_year");
                userType.AddMemberName("author_name");
                userType.AddMemberName("cover_i");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  String
                xamlType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Int32
                xamlType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  OpenLibrary.DetailsPage
                userType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_DetailsPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  OpenLibrary.MainPage
                userType = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_MainPageData_Books(object instance)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            return that.Books;
        }
        private void set_0_MainPageData_Books(object instance, object Value)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            that.Books = (global::System.Collections.ObjectModel.ObservableCollection<global::OpenLibrary.BookModel>)Value;
        }
        private object get_1_BookModel_title_suggest(object instance)
        {
            var that = (global::OpenLibrary.BookModel)instance;
            return that.title_suggest;
        }
        private void set_1_BookModel_title_suggest(object instance, object Value)
        {
            var that = (global::OpenLibrary.BookModel)instance;
            that.title_suggest = (global::System.String)Value;
        }
        private object get_2_BookModel_first_publish_year(object instance)
        {
            var that = (global::OpenLibrary.BookModel)instance;
            return that.first_publish_year;
        }
        private void set_2_BookModel_first_publish_year(object instance, object Value)
        {
            var that = (global::OpenLibrary.BookModel)instance;
            that.first_publish_year = (global::System.Int32)Value;
        }
        private object get_3_BookModel_author_name(object instance)
        {
            var that = (global::OpenLibrary.BookModel)instance;
            return that.author_name;
        }
        private void set_3_BookModel_author_name(object instance, object Value)
        {
            var that = (global::OpenLibrary.BookModel)instance;
            that.author_name = (global::System.String)Value;
        }
        private object get_4_BookModel_cover_i(object instance)
        {
            var that = (global::OpenLibrary.BookModel)instance;
            return that.cover_i;
        }
        private void set_4_BookModel_cover_i(object instance, object Value)
        {
            var that = (global::OpenLibrary.BookModel)instance;
            that.cover_i = (global::System.String)Value;
        }
        private object get_5_MainPageData_searchTerm(object instance)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            return that.searchTerm;
        }
        private void set_5_MainPageData_searchTerm(object instance, object Value)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            that.searchTerm = (global::System.String)Value;
        }
        private object get_6_MainPageData_displayTitle(object instance)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            return that.displayTitle;
        }
        private void set_6_MainPageData_displayTitle(object instance, object Value)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            that.displayTitle = (global::System.String)Value;
        }
        private object get_7_MainPageData_firstPublishedYear(object instance)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            return that.firstPublishedYear;
        }
        private void set_7_MainPageData_firstPublishedYear(object instance, object Value)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            that.firstPublishedYear = (global::System.Int32)Value;
        }
        private object get_8_MainPageData_bookAuthorName(object instance)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            return that.bookAuthorName;
        }
        private void set_8_MainPageData_bookAuthorName(object instance, object Value)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            that.bookAuthorName = (global::System.String)Value;
        }
        private object get_9_MainPageData_bookCoverImage(object instance)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            return that.bookCoverImage;
        }
        private void set_9_MainPageData_bookCoverImage(object instance, object Value)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            that.bookCoverImage = (global::System.String)Value;
        }
        private object get_10_MainPageData_SelectedBook(object instance)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            return that.SelectedBook;
        }
        private void set_10_MainPageData_SelectedBook(object instance, object Value)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            that.SelectedBook = (global::OpenLibrary.BookModel)Value;
        }
        private object get_11_MainPageData_Filter(object instance)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            return that.Filter;
        }
        private void set_11_MainPageData_Filter(object instance, object Value)
        {
            var that = (global::OpenLibrary.MainPageData)instance;
            that.Filter = (global::System.String)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember xamlMember = null;
            global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "OpenLibrary.MainPageData.Books":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.MainPageData");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "Books", "System.Collections.ObjectModel.ObservableCollection`1<OpenLibrary.BookModel>");
                xamlMember.Getter = get_0_MainPageData_Books;
                xamlMember.Setter = set_0_MainPageData_Books;
                break;
            case "OpenLibrary.BookModel.title_suggest":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.BookModel");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "title_suggest", "String");
                xamlMember.Getter = get_1_BookModel_title_suggest;
                xamlMember.Setter = set_1_BookModel_title_suggest;
                break;
            case "OpenLibrary.BookModel.first_publish_year":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.BookModel");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "first_publish_year", "Int32");
                xamlMember.Getter = get_2_BookModel_first_publish_year;
                xamlMember.Setter = set_2_BookModel_first_publish_year;
                break;
            case "OpenLibrary.BookModel.author_name":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.BookModel");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "author_name", "String");
                xamlMember.Getter = get_3_BookModel_author_name;
                xamlMember.Setter = set_3_BookModel_author_name;
                break;
            case "OpenLibrary.BookModel.cover_i":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.BookModel");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "cover_i", "String");
                xamlMember.Getter = get_4_BookModel_cover_i;
                xamlMember.Setter = set_4_BookModel_cover_i;
                break;
            case "OpenLibrary.MainPageData.searchTerm":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.MainPageData");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "searchTerm", "String");
                xamlMember.Getter = get_5_MainPageData_searchTerm;
                xamlMember.Setter = set_5_MainPageData_searchTerm;
                break;
            case "OpenLibrary.MainPageData.displayTitle":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.MainPageData");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "displayTitle", "String");
                xamlMember.Getter = get_6_MainPageData_displayTitle;
                xamlMember.Setter = set_6_MainPageData_displayTitle;
                break;
            case "OpenLibrary.MainPageData.firstPublishedYear":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.MainPageData");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "firstPublishedYear", "Int32");
                xamlMember.Getter = get_7_MainPageData_firstPublishedYear;
                xamlMember.Setter = set_7_MainPageData_firstPublishedYear;
                break;
            case "OpenLibrary.MainPageData.bookAuthorName":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.MainPageData");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "bookAuthorName", "String");
                xamlMember.Getter = get_8_MainPageData_bookAuthorName;
                xamlMember.Setter = set_8_MainPageData_bookAuthorName;
                break;
            case "OpenLibrary.MainPageData.bookCoverImage":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.MainPageData");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "bookCoverImage", "String");
                xamlMember.Getter = get_9_MainPageData_bookCoverImage;
                xamlMember.Setter = set_9_MainPageData_bookCoverImage;
                break;
            case "OpenLibrary.MainPageData.SelectedBook":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.MainPageData");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "SelectedBook", "OpenLibrary.BookModel");
                xamlMember.Getter = get_10_MainPageData_SelectedBook;
                xamlMember.Setter = set_10_MainPageData_SelectedBook;
                break;
            case "OpenLibrary.MainPageData.Filter":
                userType = (global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenLibrary.MainPageData");
                xamlMember = new global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlMember(this, "Filter", "String");
                xamlMember.Getter = get_11_MainPageData_Filter;
                xamlMember.Setter = set_11_MainPageData_Filter;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlSystemBaseType
    {
        global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::OpenLibrary.OpenLibrary_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

