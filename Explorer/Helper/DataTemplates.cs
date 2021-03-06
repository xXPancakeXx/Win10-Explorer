﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Explorer.Entities
{
    class NavigationItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DriveTemplate { get; set; }
        public DataTemplate PathTemplate { get; set; }
        public DataTemplate FavoriteTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return SelectTemplateCore(item);
        }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is Drive) return DriveTemplate;
            if (item is NavigationLink) return PathTemplate;
            if (item is FavoriteNavigationLink) return FavoriteTemplate;

            return base.SelectTemplateCore(item);
        }
    }
    class StorageItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FolderTemplate { get; set; }
        public DataTemplate FileTemplate { get; set; }
        public DataTemplate FileNoImgTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return SelectTemplateCore(item);
        }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            var fse = (FileSystemElement)item;

            if (fse.IsFolder) return FolderTemplate;
            else if (fse.Image == null) return FileNoImgTemplate;
            return FileTemplate;
        }
    }
}
