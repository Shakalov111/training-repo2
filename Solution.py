# Визначення класу для вузла бінарного дерева.
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

# Визначення класу рішення.
class Solution:
    def countNodes(self, root):
        # Допоміжна функція для отримання висоти дерева.
        def getHeight(node):
            height = 0
            while node:
                height += 1
                node = node.left
            return height
        
        # Допоміжна функція для перевірки існування вузла на заданій позиції.
        def exists(index, height, node):
            left, right = 0, 2**(height - 1) - 1
            for _ in range(height - 1):
                mid = (left + right) // 2
                if index <= mid:
                    node = node.left
                    right = mid
                else:
                    node = node.right
                    left = mid + 1
            return node is not None
        
        # Якщо корінь порожній, повертаємо 0.
        if not root:
            return 0
        
        # Отримуємо висоту дерева.
        height = getHeight(root)
        # Якщо висота дерева дорівнює 1, повертаємо 1.
        if height == 1:
            return 1
        
        # Ініціалізуємо межі для бінарного пошуку.
        left, right = 0, 2**(height - 1) - 1
        while left <= right:
            mid = (left + right) // 2
            # Перевіряємо, чи існує вузол на позиції mid.
            if exists(mid, height, root):
                left = mid + 1
            else:
                right = mid - 1
        
        # Повертаємо загальну кількість вузлів.
        return (2**(height - 1) - 1) + left