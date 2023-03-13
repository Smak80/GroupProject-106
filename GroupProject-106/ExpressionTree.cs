using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Parsing
{
    internal class ExpressionTree
    {
        private ExpressionTreeNode Root { get; set; }


        public ExpressionTreeNode AddNewNode(ExpressionTreeNode newNode, ExpressionTreeNode currentNode = null)
        {
            if (Root == null)
            {
                Root = newNode;
                newNode.ParentNode = null;
            }

            currentNode = currentNode ?? Root;

            newNode.ParentNode = currentNode;

            int result; 

            return (result = newNode._preparsed_expression.CompareTo(currentNode._preparsed_expression)) == 0
                ? currentNode 
                : result < 0
                    ? currentNode.LeftNode == null
                        ? (currentNode.LeftNode = newNode)
                        : AddNewNode(newNode, currentNode.LeftNode)
                    : currentNode.RightNode == null
                        ? (currentNode.RightNode = newNode)
                        : AddNewNode(newNode, currentNode.RightNode);


        }



    }
}
