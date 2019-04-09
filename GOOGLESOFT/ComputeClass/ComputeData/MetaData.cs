using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data = Google.Apis.Compute.v1.Data;
using System.Windows.Forms;

namespace GOOGLESOFT.ComputeClass.ComuteData
{
    internal class MetaData
    {
        private Data.Metadata md;       
        
        MetaData()
        {
            md = new Data.Metadata();            
        }

        public Data.Metadata GetMetadata()
        {
            return md;
        }

        void Add(string key, string value)
        {
            try
            {
                var item = new Data.Metadata.ItemsData();
                item.Key = key;
                item.Value = value;
                md.Items.Add(item);
            }
            catch(Exception e)
            {
                MessageBox.Show("메타데이터 키밸류 추가 중" + e.ToString());
                return;
            }            
        }

        void Delete(string key, string value) // 둘 중 하나만 일치해도 제거
        {
            try
            {
                var it = new Data.Metadata.ItemsData();
                it.Key = key;
                it.Value = value;
                md.Items.Remove(it);
            }
            catch (Exception e)
            {
                MessageBox.Show("메타데이터 키밸류 제거 중" + e.ToString());
                return;
            }
        }

        void Delete(int index )
        {
            try
            {
                md.Items.RemoveAt(index);
            }
            catch (Exception e)
            {
                MessageBox.Show("메타데이터 키밸류 제거 중" + e.ToString());
                return;
            }
        }
    }
}
