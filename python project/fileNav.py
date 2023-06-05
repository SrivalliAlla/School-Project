'''
You are building a file system navigation tool that represents
directories and files as a tree structure.
Each directory can contain subdirectories and files.
You need to implement a Tree class to represent this file system structure.

Requirements:

Each node in the tree should represent either a directory or a file.
Each directory node can have multiple child nodes (subdirectories and files).
Each file node should store the file name and its size in bytes.
The Tree class should support the following operations:
Insert a directory or file into the tree.
Remove a directory or file from the tree.
Search for a directory or file in the tree.
Get the total size of a directory (including all its subdirectories and files).
Traverse the tree and print the directory/file structure.
Implement the Tree class in Python to meet the requirements of this scenario
'''

class Node:
    def __init__(self, name):
        self.name = name


class Directory(Node):
    def __init__(self, name):
        super().__init__(name)
        self.children = []

    def add_child(self, node):
        self.children.append(node)

    def remove_child(self, node):
        self.children.remove(node)

    def get_child(self, name):
        for child in self.children:
            if child.name == name:
                return child
        return None

    def get_size(self):
        total_size = 0
        for child in self.children:
            total_size += child.get_size()
        return total_size


class File(Node):
    def __init__(self, name, size):
        super().__init__(name)
        self.size = size

    def get_size(self):
        return self.size


class Tree:
    def __init__(self):
        self.root = Directory("root")

    def insert(self, path, node):
        current_dir = self.root
        components = path.split("/")
        for component in components[:-1]:
            current_dir = current_dir.get_child(component)
            if current_dir is None or not isinstance(current_dir, Directory):
                raise ValueError(f"Invalid path: {path}")

        current_dir.add_child(node)

    def remove(self, path):
        components = path.split("/")
        parent_dir = self.root
        current_dir = self.root
        for component in components[:-1]:
            parent_dir = current_dir
            current_dir = current_dir.get_child(component)
            if current_dir is None or not isinstance(current_dir, Directory):
                raise ValueError(f"Invalid path: {path}")

        node = current_dir.get_child(components[-1])
        if node is None:
            raise ValueError(f"Invalid path: {path}")

        parent_dir.remove_child(node)

    def search(self, path):
        current_dir = self.root
        components = path.split("/")
        for component in components:
            current_dir = current_dir.get_child(component)
            if current_dir is None:
                return None

        return current_dir

    def get_directory_size(self, path):
        directory = self.search(path)
        if directory is None or not isinstance(directory, Directory):
            raise ValueError(f"Invalid directory: {path}")

        return directory.get_size()

    def traverse(self):
        self._traverse_helper(self.root, "")

    def _traverse_helper(self, node, indent):
        print(indent + node.name)
        if isinstance(node, Directory):
            for child in node.children:
                self._traverse_helper(child, indent + "  ")
