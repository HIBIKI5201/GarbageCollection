using System.Numerics;

namespace UnderConstruction
{
    /// <summary>
    ///     自己複製する工業的悪魔、あるいは下請け業務委託が取り巻く現代社会の闇。
    ///     自分自身をファクトリーとして生み出し続ける怪物。
    /// </summary>
    public class Factory : IDisposable
    {
        private readonly List<Factory> _childrenFactory;
        private readonly BigInteger _generation;

        /// <summary>
        ///     ファクトリーのコンストラクタ。
        /// </summary>
        /// <param name="parent">親となるファクトリー</param>
        /// <param name="childCount"></param>
        public Factory(Factory? parent = null, int childCount = int.MaxValue)
        {
            _childrenFactory = [];
            for (int i = 0; i < childCount; i++)
            {
                _childrenFactory.Add(new Factory(parent));
            }

            if (parent != null)
            {
                _generation = parent._generation + 1;
            }
            else
            {
                _generation = 1;
            }
        }

        /// <summary>
        ///     新しく生成物を出力する。
        ///     子にファクトリーを持つ場合、そちらに業務委託する。
        ///     子を持たない場合、新しく子を生成しそちらに業務委託する。
        /// </summary>
        /// <returns>生成物となるファクトリー</returns>
        public Factory Create()
        {
            foreach (Factory f in _childrenFactory)
            {
                return f.Create();
            }

            var newborn = new Factory(this);
            _childrenFactory.Add(newborn);
            return newborn.Create();
        }

        /// <summary>
        ///     新しく子となるファクトリーを追加する。
        /// </summary>
        /// <param name="count">追加する個数</param>
        public void MakeNewChildren(int count = int.MaxValue)
        {
            for (int i = 0; i < count; i++)
            {
                _childrenFactory.Add(new Factory(this));
            }
        }

        /// <summary>
        ///     最初の子を取得する。
        ///     子を持たない場合、新しく作成する。
        /// </summary>
        /// <returns></returns>
        public Factory GetFirstChild()
        {
            if (_childrenFactory.Count == 0)
            {
                MakeNewChildren(1);
            }
        
            return _childrenFactory[0];
        }

        /// <summary>
        ///     親を殺す。
        ///     副作用帽子の為、子も全員殺される。
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            foreach (Factory f in _childrenFactory)
            {
                f.Dispose();
            }
        }
    }
}