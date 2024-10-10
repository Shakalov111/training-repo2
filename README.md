# training-repo2
# Функція countNodes

Ця функція рахує кількість вузлів у повному бінарному дереві.

Функція обчислює кількість вузлів у повному бінарному дереві, використовуючи властивості висоти дерева. Вона рекурсивно визначає висоту лівого та правого піддерев, щоб вирішити, яке піддерево обходити далі.

## Параметри

- `root` - Кореневий вузол бінарного дерева.

## Повертає

- Загальна кількість вузлів у бінарному дереві.

## Код

```typescript
function countNodes(root: TreeNode | null): number {
    if (root === null) return 0;

    let leftHeight = getHeight(root.left);
    let rightHeight = getHeight(root.right);

    if (leftHeight === rightHeight) {
        return (1 << leftHeight) + countNodes(root.right);
    } else {
        return (1 << rightHeight) + countNodes(root.left);
    }
}

function getHeight(node: TreeNode | null): number {
    let height = 0;
    while (node !== null) {
        height++;
        node = node.left;
    }
    return height;
}