using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmKNN
{
    public class Node
    {
        public Train point{get;set;}     //节点信息
        public Node leftNode { get; set; }   //左子树
        public Node righNode { get; set; }   //右子树
        public int split { get; set; }       //分割的方向轴序号
        public Node parent { get; set; }     //父节点
        public List<Train> range { get; set; }   //空间节点
    }

    public class Train
    {
        public float positionX { get; set; }
        public float positionY { get; set; }
        public float positionZ { get; set; }
        public Int32 AvgRssi { set; get; }
    }

    public class PriorityList
    {
        public Node node { get; set; }
        public float priority { get; set; }
    }
}
