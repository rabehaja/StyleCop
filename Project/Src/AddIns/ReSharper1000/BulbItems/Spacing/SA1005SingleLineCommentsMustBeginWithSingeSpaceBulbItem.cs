// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SA1005SingleLineCommentsMustBeginWithSingeSpaceBulbItem.cs" company="http://stylecop.codeplex.com">
//   MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
// <summary>
//   The s a 1005 single line comments must begin with singe space.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace StyleCop.ReSharper1000.BulbItems.Spacing
{
    using JetBrains.ProjectModel;
    using JetBrains.ReSharper.Psi.Tree;
    using JetBrains.TextControl;

    using StyleCop.ReSharper1000.BulbItems.Framework;
    using StyleCop.ReSharper1000.CodeCleanup.Rules;
    using StyleCop.ReSharper1000.Core;

    /// <summary>
    /// The s a 1005 single line comments must begin with singe space.
    /// </summary>
    public class SA1005SingleLineCommentsMustBeginWithSingeSpaceBulbItem : V5BulbItemImpl
    {
        /// <summary>
        /// The execute transaction inner.
        /// </summary>
        /// <param name="solution">
        /// The solution.
        /// </param>
        /// <param name="textControl">
        /// The text control.
        /// </param>
        public override void ExecuteTransactionInner(ISolution solution, ITextControl textControl)
        {
            Utils.FormatLineForTextControl(solution, textControl);

            ITreeNode element = Utils.GetElementAtCaret(solution, textControl);
            SpacingRules.SingleLineCommentsMustBeginWithSingleSpace(element);
        }
    }
}