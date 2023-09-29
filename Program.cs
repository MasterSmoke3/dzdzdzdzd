// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class HighScores {
constructor() {
this.scores = [];
this.maxScores = 10;
}

addScore(score) {
if (this.scores.length <= this.maxScores) {
this.scores.push(score);
}
}

removeScore(score) {
this.sctores.splice(index, 1);
}
}

class Node {
constructor(value) {
this.value = value;
this.next = next;
}
}

class SinglyLinkedList {
constructor(head) {
this.head = head;
this.length = 1;
}
}

addElem(number) {
const lastElem = this.head;
for (let i = 0; i <= this.length; i++) {
let lastElem = lastElem.next;
}
while (lastElem, next = null) { //не равно
lastElem = lastElem.next
}

const newNode = new Node(number, null);
lastElem next = newNode;
}

deleteElem(index) {
let elemToDelete = head;
let prevElem = null;
for (int i = 0; i <= index; i++ ) {
prevElem = elemToDelete;
elemToDelete - elemToDelete.next;
}
prevElem next = elemToDelete.next;
}

const node1 = new Node(7, null);
const node2 = new Node(3, node1);
const list = new SinglyLinkedList(node2);

// const obj2 = {value: 3};
// const obj1 = {value: };

// const test = new HighScores();

node2.next