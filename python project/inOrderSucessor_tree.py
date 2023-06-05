class Node:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None
        self.parent = None

def inOrderSuccessor(node):
    if node.right is not None:
        return minimumValue(node.right)

    t = node.parent
    while t is not None:
        if node != t.right:
            break
        node = t
        t = t.parent
    return t

def minimumValue(node):
    c = node
    while c is not None:
        if c.left is None:
            break
        c = c.left
    return c

def insert(node, data):
    if node is None:
        return Node(data)
    else:
        if data <= node.data:
            t = insert(node.left, data)
            node.left = t
            t.parent = node
        else:
            t = insert(node.right, data)
            node.right = t
            t.parent = node
        return node

if __name__ == "__main__":
    root = None
    root = insert(root, 20)
    root = insert(root, 8)
    root = insert(root, 22)
    root = insert(root, 4)
    root = insert(root, 12)
    root = insert(root, 10)
    root = insert(root, 14)

    temp = root.left.right.right

    x = inOrderSuccessor(temp)
    if x is not None:
        print("In-order successor of %d is %d" % (temp.data, x.data))
    else:
        print("In-order successor does not exist")
