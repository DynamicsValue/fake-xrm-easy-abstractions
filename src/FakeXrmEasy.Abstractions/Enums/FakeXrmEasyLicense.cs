namespace FakeXrmEasy.Abstractions.Enums
{
    /// <summary>
    /// Defines the available licenses you can choose when using FakeXrmEasy. For more info: https://github.com/DynamicsValue/licence-agreements/blob/main/FakeXrmEasy/LICENSE.md
    /// </summary>
    public enum FakeXrmEasyLicense
    {
        /// <summary>
        /// You are agreeing to use FakeXrmEasy under the Reciprocal Public License 1.5 defined at https://github.com/DynamicsValue/licence-agreements/blob/main/FakeXrmEasy/RPL_1_5.md
        /// </summary>
        RPL_1_5 = 0,

        /// <summary>
        /// You are agreeing to use FakeXrmEasy under the Modified Polyform Non-commercial License 1.0.0 defined at https://github.com/DynamicsValue/licence-agreements/blob/main/FakeXrmEasy/LICENSE.md
        /// </summary>
        NonCommercial = 1,

        /// <summary>
        /// You are agreeing to use FakeXrmEasy under the Commercial License defined at https://github.com/DynamicsValue/licence-agreements/blob/main/FakeXrmEasy/EULA.md
        /// </summary>
        Commercial = 2
    }
}
