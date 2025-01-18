namespace Patterns_2.Composite;

// Абстрактний базовий компонент
public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public DateTime Created { get; }
        
        protected FileSystemItem(string name)
        {
            Name = name;
            Created = DateTime.Now;
        }

        public abstract void Display(int depth = 0);
        public abstract int GetSize();
    }

// Листовий компонент - Файл
public class File : FileSystemItem
    {
        private int Size { get; }
        public string Extension { get; }

        public File(string name, int size) : base(name)
        {
            Size = size;
            Extension = System.IO.Path.GetExtension(name);
        }

        public override void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}└── {Name} ({FormatSize(Size)})");
        }

        public override int GetSize()
        {
            return Size;
        }

        private string FormatSize(int bytes)
        {
            if (bytes < 1024) return $"{bytes} B";
            if (bytes < 1024 * 1024) return $"{bytes / 1024} KB";
            return $"{bytes / (1024 * 1024)} MB";
        }
    }

// Складений компонент - Директорія
public class Directory : FileSystemItem
    {
        private List<FileSystemItem> _children;

        public Directory(string name) : base(name)
        {
            _children = new List<FileSystemItem>();
        }

        public void Add(FileSystemItem item)
        {
            _children.Add(item);
        }

        public bool Remove(string name)
        {
            var item = _children.FirstOrDefault(x => x.Name == name);
            if (item != null)
            {
                return _children.Remove(item);
            }
            return false;
        }

        public FileSystemItem? Find(string name)
        {
            foreach (var item in _children)
            {
                if (item.Name == name) return item;
                if (item is Directory dir)
                {
                    var found = dir.Find(name);
                    if (found != null) return found;
                }
            }
            return null;
        }

        public override void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 2)}├── {Name}/");
            foreach (var item in _children)
            {
                item.Display(depth + 1);
            }
            if (depth == 0)
            {
                Console.WriteLine($"\nTotal size: {FormatSize(GetSize())}");
            }
        }

        public override int GetSize()
        {
            return _children.Sum(x => x.GetSize());
        }

        private string FormatSize(int bytes)
        {
            if (bytes < 1024) return $"{bytes} B";
            if (bytes < 1024 * 1024) return $"{bytes / 1024} KB";
            return $"{bytes / (1024 * 1024)} MB";
        }
    }

// Клас для управління файловою системою
public class FileSystem
{
        private Directory root;

        public FileSystem()
        {
            root = new Directory("root");
        }

        public void CreateFile(string path, int size)
        {
            var (parentPath, fileName) = SplitPath(path);
            var parent = NavigateToPath(parentPath);
            
            if (parent != null)
            {
                parent.Add(new File(fileName, size));
                Console.WriteLine($"File '{fileName}' created successfully.");
            }
        }

        public void CreateDirectory(string path)
        {
            var (parentPath, dirName) = SplitPath(path);
            var parent = NavigateToPath(parentPath);
            
            if (parent != null)
            {
                parent.Add(new Directory(dirName));
                Console.WriteLine($"Directory '{dirName}' created successfully.");
            }
        }

        public void Delete(string path)
        {
            var (parentPath, itemName) = SplitPath(path);
            var parent = NavigateToPath(parentPath);
            
            if (parent != null && parent.Remove(itemName))
            {
                Console.WriteLine($"'{itemName}' deleted successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public void ShowTree()
        {
            root.Display();
        }

        public void ShowInfo(string path)
        {
            var item = NavigateToPath(path);
            if (item != null)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Created: {item.Created}");
                Console.WriteLine($"Size: {item.GetSize()} bytes");
                if (item is Directory)
                {
                    Console.WriteLine("Type: Directory");
                }
                else
                {
                    Console.WriteLine("Type: File");
                }
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        private (string parentPath, string name) SplitPath(string path)
        {
            var parts = path.Split('/').Where(x => !string.IsNullOrEmpty(x)).ToList();
            if (parts.Count == 0) return ("", "");
            if (parts.Count == 1) return ("", parts[0]);
            return (string.Join("/", parts.Take(parts.Count - 1)), parts.Last());
        }

        private Directory? NavigateToPath(string path)
        {
            if (string.IsNullOrEmpty(path)) return root;
            
            var current = root;
            var parts = path.Split('/').Where(x => !string.IsNullOrEmpty(x));
            
            foreach (var part in parts)
            {
                var item = current.Find(part);
                if (item == null || item is not Directory)
                {
                    Console.WriteLine($"Path '{path}' not found.");
                    return null;
                }
                current = (Directory)item;
            }
            
            return current;
        }
}