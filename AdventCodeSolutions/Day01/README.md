# Advent of Code - Day 1: Historian Hysteria 🎄

## 🚀 Task Overview

The **Chief Historian** is crucial for the big Christmas sleigh launch, but he's been missing for months! Last anyone heard, he was exploring historically significant places in the **North Pole**, and now a group of **Senior Historians** has asked for your help.

They believe the Chief Historian is somewhere among the **first 50 locations** they plan to check. Your mission is to help them get **50 stars** on their list before **Santa leaves** on December 25th. Each star comes from solving puzzles in the Advent calendar. Each day, you'll unlock two puzzles, one after the other.

---

## 🔍 The Problem

Before you can even begin, the group of Historians encounters an issue: their list of places to search is empty. They quickly decide the first place to check should be the **Chief Historian's office**.

Upon investigating the office, they find a bunch of **notes** and **lists** of historically significant locations—numbers called **location IDs**. The only problem? There are two lists, and they don’t match up!

### The challenge is: **Can you help reconcile these lists?**

---

## 🧩 How It Works

The two groups of Historians are each working on their own list of location IDs. When you compare the two lists side by side, you notice they’re quite different. Maybe you can figure out how far apart they are by pairing up their corresponding location IDs and calculating the difference.

### Example Input:

**Left List**:  

3 4
4 3
2 5
1 3
3 9
3 3

---

**Right List**:  

4 3
3 5
3 3
2 1
3 5
9 3

---


---

## 🔢 Solution Approach

1. **Sort both lists** in ascending order.
2. **Pair up the corresponding elements** from both lists (smallest with smallest, second smallest with second smallest, etc.).
3. **Calculate the absolute difference** between each pair.
4. **Sum up the distances** between all the pairs to get the final result.

### Example Calculation:

Given the sorted lists:

- **Left List**: `1, 2, 3, 3, 3, 4`
- **Right List**: `3, 3, 3, 4, 5, 9`

Here are the steps to calculate the total distance:

- Pair 1: |1 - 3| = 2
- Pair 2: |2 - 3| = 1
- Pair 3: |3 - 3| = 0
- Pair 4: |3 - 4| = 1
- Pair 5: |3 - 5| = 2
- Pair 6: |4 - 9| = 5

### Total Distance:
`2 + 1 + 0 + 1 + 2 + 5 = 11`

---

## 🏁 What’s Next?

Your task is to take the **actual left and right lists** of location IDs (provided in the puzzle input) and calculate the total distance between them using the steps outlined above.

The challenge is a simple yet effective way to practice your **problem-solving** and **programming skills** as you work through sorting, calculating absolute differences, and summing values.

---

## 🧑‍💻 Running the Solution

To run this solution and calculate the total distance between the two lists:

1. **Clone this repository**:
   ```bash
   git clone <repo-url>
