using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
             //LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
             LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            List<string> lists = new List<string>();    
            //lists.Add
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("node 1");
            linkedList.AddLast("node 2");
            linkedList.AddFirst("node 0");
            PrintLinkList(linkedList);

            LinkedListNode<string> firstNode = linkedList.First;
            Debug.Log("first : " + firstNode.Value);

            LinkedListNode<string> lastNode = linkedList.Last;
            Debug.Log("last" + lastNode.Value);


            LinkedListNode<string> node1 = linkedList.Find("node 1");
            Debug.Log("node: " + node1.Value);
            Debug.Log(node1.Previous.Value);
            Debug.Log(node1.Next.Value);

            if (firstNode.Previous == null) { Debug.Log("firstnode.Previous is null"); }
            if (lastNode.Previous == null) { Debug.Log("lastNode.Next is null"); }
            //Debug.Log(firstNode.Previous.Value == null ? "test" : Break);


            linkedList.AddAfter(node1, "node 1.5");
            linkedList.AddBefore(node1, "node 0.5");
            PrintLinkList(linkedList);

            linkedList.RemoveFirst();
            PrintLinkList(linkedList);

            linkedList.Remove("node 2");
            PrintLinkList(linkedList);


            linkedList.Clear();
            PrintLinkList(linkedList);
        }

        void PrintLinkList(LinkedList<string> linkedList)
        {
            Debug.Log("------------ LinkedList ------------");
            foreach (string s in linkedList)
            {
                Debug.Log(s);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
        }

        public void LCT04_SyntaxDictionary()
        {
            //throw new System.NotImplementedException();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary[3] = "Cherry";

            //Debug.Log(dictionary[4]);

            int keytocheck = 1;
            bool hasKey = dictionary.ContainsKey(keytocheck);
            Debug.Log($"has key {keytocheck}:{hasKey}");
            if (hasKey)
            {
                Debug.Log(dictionary[keytocheck]);
            }

            Debug.Log("------ KEY ------");
            foreach (int k in dictionary.Keys)
            {
                Debug.Log(k);
            }

            Debug.Log("------ VALUE ------");
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }

            Debug.Log("------ REMOVE ------");
            dictionary.Remove(1);
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }

            Debug.Log("------ REMOVE ------");
            dictionary.Clear();
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }

            
        }

        #endregion
    }
}
