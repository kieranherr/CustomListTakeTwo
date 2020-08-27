CustomListTakeTwo


public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    if(list1[j].Equals(list2[i]))
                    {
                        list1.Remove(list2[i]);
                    }
                }
            }
            return list1;
        }

Parameters:
list1 CustomList<T>
The list that is subtraced from;

list2 CustomList<T>
The list to subtract from list1;

Returns:
CustomList<T>

list1 once the subtraction has completed;




