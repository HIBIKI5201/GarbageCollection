namespace UnderConstruction
{
    /// <summary>
    ///     超普遍的な深度優先探索アルゴリズムを行うプログラム
    ///     入力については以下を参照（Paizaから引用）
    /// 
    ///         n s t
    ///         v_1
    ///         a_{1,1} a_{1,2} ... a_{1,v_1}
    ///         v_2
    ///         a_{2,1} ... a_{2,v_2}
    ///         ...
    ///         v_n
    ///         a_{n,1} ... a_{n,v_n}
    ///     
    ///     1 行目に、頂点の個数を表す整数 n と、端点の頂点番号 s と t が与えられます。
    ///     
    ///     2i 行目には頂点 i に隣接している頂点の個数が与えられ、 2i+1 行目には頂点 i に隣接している頂点の番号が半角スペース区切りで与えられます。(1 ≦ i ≦ n)
    ///     
    ///     入力値最終行の末尾に改行が１つ入ります。
    /// </summary>
    public class UltimateOrdinaryDepthFirstSearchThatYouHaveNeverSeenBeforeInYourEntireLimitationOfLife
    {
        private static readonly Dictionary<int, List<int>>
            _adjacentDictionaryThatContainsWhereWeWillGoingToReachesTheEndOfMostLongestVoyageBelongsToTheUltimateOrdinalDepthFirstSearch =
                new();

        private static readonly List<string>
            _routeListThatWeHaveBeenPassedOutFromUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife =
                [];

        private static void Main()
        {
            var inputThatComeFromCommandLineInterfaceOfReadLine = Console.ReadLine();
            if (inputThatComeFromCommandLineInterfaceOfReadLine != "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var numbersThatConvertedFromInput =
                Array.ConvertAll(inputThatComeFromCommandLineInterfaceOfReadLine.Split(), int.Parse);

            (int countOfVerticesThatGivenFromAfterInputs, int pointOfStartAlsoConsideredAsBeginningOfMostLargestVoyage,
                int pointOfGoalAlsoConsideredAsTermination) = (numbersThatConvertedFromInput[0],
                numbersThatConvertedFromInput[1], numbersThatConvertedFromInput[2]);

            for (int indexOfForLoopThatRepeatsUntilItReachesCountOfVerticesThatGivenFromInput = 1;
                 indexOfForLoopThatRepeatsUntilItReachesCountOfVerticesThatGivenFromInput <=
                 countOfVerticesThatGivenFromAfterInputs;
                 indexOfForLoopThatRepeatsUntilItReachesCountOfVerticesThatGivenFromInput++)
            {
                // 頂点個数が渡されるが不要なので飛ばす。
                Console.ReadLine();
                var inputThatComeFromCommandLineInterfaceOfReadLineEx = Console.ReadLine();
                if (inputThatComeFromCommandLineInterfaceOfReadLineEx != "")
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                var verticesInformationOfArrayThatTakesFromInputThatComesFromReadLine =
                    Array.ConvertAll(inputThatComeFromCommandLineInterfaceOfReadLineEx.Split(), int.Parse);

                // キーを頂点、値をその頂点に隣接した別の頂点として保存。
                _adjacentDictionaryThatContainsWhereWeWillGoingToReachesTheEndOfMostLongestVoyageBelongsToTheUltimateOrdinalDepthFirstSearch
                    .Add(
                        indexOfForLoopThatRepeatsUntilItReachesCountOfVerticesThatGivenFromInput,
                        [..verticesInformationOfArrayThatTakesFromInputThatComesFromReadLine]);
            }

            var pathOfStackWhereWeAraLeadingToTheEndOfTerminationOfMostLargestVoyage = new Stack<int>();
            pathOfStackWhereWeAraLeadingToTheEndOfTerminationOfMostLargestVoyage.Push(
                pointOfStartAlsoConsideredAsBeginningOfMostLargestVoyage);
            ExecutesTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife(
                pathOfStackWhereWeAraLeadingToTheEndOfTerminationOfMostLargestVoyage,
                pointOfStartAlsoConsideredAsBeginningOfMostLargestVoyage,
                pointOfGoalAlsoConsideredAsTermination);
            Console.WriteLine(
                _routeListThatWeHaveBeenPassedOutFromUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife
                    .Count);
            foreach (var s in
                     _routeListThatWeHaveBeenPassedOutFromUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife)
            {
                Console.WriteLine(s);
            }
        }

        /// <summary>
        /// 深度優先探索を行う。
        /// </summary>
        /// <param name="pathOfStackWhereWeAreCurrentlyLeadingToTheEndOfTerminationFromPointOfBeginning">現在の進行ルート</param>
        /// <param name="pointOfStartThatBeginningOfTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife">探索の開始地点</param>
        /// <param name="pointOfEndThatTerminationOfTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife">探索の終了地点</param>
        private static void ExecutesTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife(
            Stack<int> pathOfStackWhereWeAreCurrentlyLeadingToTheEndOfTerminationFromPointOfBeginning,
            int pointOfStartThatBeginningOfTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife,
            int pointOfEndThatTerminationOfTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife)
        {
            foreach (int currentVertexWhereWeAreAtFromTheMostLargestVoyage
                     in _adjacentDictionaryThatContainsWhereWeWillGoingToReachesTheEndOfMostLongestVoyageBelongsToTheUltimateOrdinalDepthFirstSearch
                     [
                         pointOfStartThatBeginningOfTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife])
            {
                if (!pathOfStackWhereWeAreCurrentlyLeadingToTheEndOfTerminationFromPointOfBeginning.Contains(
                        currentVertexWhereWeAreAtFromTheMostLargestVoyage))
                {
                    // 次の探索候補をスタックに入れる。
                    pathOfStackWhereWeAreCurrentlyLeadingToTheEndOfTerminationFromPointOfBeginning.Push(
                        currentVertexWhereWeAreAtFromTheMostLargestVoyage);

                    if (currentVertexWhereWeAreAtFromTheMostLargestVoyage ==
                        pointOfEndThatTerminationOfTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife)
                    {
                        // 候補がゴールの場合、ルートを記録。
                        _routeListThatWeHaveBeenPassedOutFromUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife
                            .Add(string.Join(" ",
                                pathOfStackWhereWeAreCurrentlyLeadingToTheEndOfTerminationFromPointOfBeginning
                                    .Reverse()));
                    }
                    else
                    {
                        // ゴール出ない場合は、移動して探索を再開。
                        ExecutesTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife(
                            pathOfStackWhereWeAreCurrentlyLeadingToTheEndOfTerminationFromPointOfBeginning,
                            currentVertexWhereWeAreAtFromTheMostLargestVoyage,
                            pointOfEndThatTerminationOfTheUltimateOrdinalDepthFirstSearchThatYouHaveNeverSeenBeforeInYourLife);
                    }

                    // 探索を終えたので、スタックから取り除く。
                    pathOfStackWhereWeAreCurrentlyLeadingToTheEndOfTerminationFromPointOfBeginning.Pop();
                }
            }

            // 行ける箇所がなかった場合、行き止まりに到達したとして探索を打ち切る
        }
    }
}