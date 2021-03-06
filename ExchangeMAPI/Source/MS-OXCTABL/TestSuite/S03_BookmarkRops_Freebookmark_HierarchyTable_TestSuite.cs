//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCTABL {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.Protocols.TestTools;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3130.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuite : PtfTestClassBase {
        
        public S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "2000000");
        }
        
        #region Expect Delegates
        public delegate void CheckMAPIHTTPTransportSupportedDelegate1(bool isSupported);
        
        public delegate void CheckRequirementEnabledDelegate1(bool enabled);
        #endregion
        
        #region Event Metadata
        static System.Reflection.MethodBase CheckMAPIHTTPTransportSupportedInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "CheckMAPIHTTPTransportSupported", typeof(bool).MakeByRefType());
        
        static System.Reflection.MethodBase CheckRequirementEnabledInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter), "CheckRequirementEnabled", typeof(int), typeof(bool).MakeByRefType());
        #endregion
        
        #region Adapter Instances
        private Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter IMS_OXCTABLAdapterInstance;
        #endregion
        
        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context) {
            PtfTestClassBase.Initialize(context);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup() {
            PtfTestClassBase.Cleanup();
        }
        #endregion
        
        #region Test Initialization and Cleanup
        protected override void TestInitialize() {
            this.InitializeTestManager();
            this.IMS_OXCTABLAdapterInstance = ((Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocols.TestSuites.MS_OXCTABL.IMS_OXCTABLAdapter))));
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuite() {
            this.Manager.BeginTest("MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuite");
            this.Manager.Comment("reaching state \'S0\'");
            bool temp0;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCTABLAdapterInstance.CheckMAPIHTTPTransportSupported(out temp0);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp0);
            this.Manager.Comment("reaching state \'S1\'");
            int temp9 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuiteCheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuiteCheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp9 == 0)) {
                this.Manager.Comment("reaching state \'S2\'");
                goto label1;
            }
            if ((temp9 == 1)) {
                this.Manager.Comment("reaching state \'S3\'");
                this.Manager.Comment("executing step \'call InitializeTable(HIERARCHY_TABLE)\'");
                this.IMS_OXCTABLAdapterInstance.InitializeTable(((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableType)(1)));
                this.Manager.Comment("reaching state \'S4\'");
                this.Manager.Comment("checking step \'return InitializeTable\'");
                this.Manager.Comment("reaching state \'S5\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp1;
                this.Manager.Comment("executing step \'call RopSetColumns(1,False,False,False)\'");
                temp1 = this.IMS_OXCTABLAdapterInstance.RopSetColumns(1u, false, false, false);
                this.Manager.Checkpoint("MS-OXCTABL_R829");
                this.Manager.Checkpoint("MS-OXCTABL_R45");
                this.Manager.Comment("reaching state \'S6\'");
                this.Manager.Comment("checking step \'return RopSetColumns/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp1, "return of RopSetColumns, state S6");
                this.Manager.Comment("reaching state \'S7\'");
                Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp2;
                this.Manager.Comment("executing step \'call RopCreateBookmark()\'");
                temp2 = this.IMS_OXCTABLAdapterInstance.RopCreateBookmark();
                this.Manager.Checkpoint("MS-OXCTABL_R857");
                this.Manager.Comment("reaching state \'S8\'");
                this.Manager.Comment("checking step \'return RopCreateBookmark/success\'");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp2, "return of RopCreateBookmark, state S8");
                this.Manager.Comment("reaching state \'S9\'");
                bool temp3;
                this.Manager.Comment("executing step \'call CheckRequirementEnabled(549,out _)\'");
                this.IMS_OXCTABLAdapterInstance.CheckRequirementEnabled(549, out temp3);
                this.Manager.AddReturn(CheckRequirementEnabledInfo, null, temp3);
                this.Manager.Comment("reaching state \'S10\'");
                int temp8 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuite.CheckRequirementEnabledInfo, null, new CheckRequirementEnabledDelegate1(this.MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuiteCheckRequirementEnabledChecker)), new ExpectedReturn(S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuite.CheckRequirementEnabledInfo, null, new CheckRequirementEnabledDelegate1(this.MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuiteCheckRequirementEnabledChecker1)));
                if ((temp8 == 0)) {
                    this.Manager.Comment("reaching state \'S11\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp4;
                    this.Manager.Comment("executing step \'call RopFreeBookmark()\'");
                    temp4 = this.IMS_OXCTABLAdapterInstance.RopFreeBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R547");
                    this.Manager.Comment("reaching state \'S13\'");
                    this.Manager.Comment("checking step \'return RopFreeBookmark/success\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp4, "return of RopFreeBookmark, state S13");
                    this.Manager.Comment("reaching state \'S15\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp5;
                    this.Manager.Comment("executing step \'call RopSeekRowBookmark(True,True,True)\'");
                    temp5 = this.IMS_OXCTABLAdapterInstance.RopSeekRowBookmark(true, true, true);
                    this.Manager.Checkpoint("MS-OXCTABL_R852");
                    this.Manager.Checkpoint("MS-OXCTABL_R511");
                    this.Manager.Checkpoint("MS-OXCTABL_R2481");
                    this.Manager.Checkpoint("MS-OXCTABL_R5521");
                    this.Manager.Comment("reaching state \'S17\'");
                    this.Manager.Comment("checking step \'return RopSeekRowBookmark/ecInvalidBookmark\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues.ecInvalidBookmark, temp5, "return of RopSeekRowBookmark, state S17");
                    this.Manager.Comment("reaching state \'S19\'");
                    goto label0;
                }
                if ((temp8 == 1)) {
                    this.Manager.Comment("reaching state \'S12\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp6;
                    this.Manager.Comment("executing step \'call RopFreeBookmark()\'");
                    temp6 = this.IMS_OXCTABLAdapterInstance.RopFreeBookmark();
                    this.Manager.Checkpoint("MS-OXCTABL_R547");
                    this.Manager.Comment("reaching state \'S14\'");
                    this.Manager.Comment("checking step \'return RopFreeBookmark/success\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, ((Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues)(0)), temp6, "return of RopFreeBookmark, state S14");
                    this.Manager.Comment("reaching state \'S16\'");
                    Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues temp7;
                    this.Manager.Comment("executing step \'call RopSeekRowBookmark(True,True,True)\'");
                    temp7 = this.IMS_OXCTABLAdapterInstance.RopSeekRowBookmark(true, true, true);
                    this.Manager.Checkpoint("MS-OXCTABL_R852");
                    this.Manager.Checkpoint("MS-OXCTABL_R511");
                    this.Manager.Checkpoint("MS-OXCTABL_R2481");
                    this.Manager.Checkpoint("MS-OXCTABL_R5521");
                    this.Manager.Comment("reaching state \'S18\'");
                    this.Manager.Comment("checking step \'return RopSeekRowBookmark/ecInvalidBookmark\'");
                    TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues>(this.Manager, Microsoft.Protocols.TestSuites.MS_OXCTABL.TableRopReturnValues.ecInvalidBookmark, temp7, "return of RopSeekRowBookmark, state S18");
                    this.Manager.Comment("reaching state \'S20\'");
                    goto label0;
                }
                throw new InvalidOperationException("never reached");
            label0:
;
                goto label1;
            }
            throw new InvalidOperationException("never reached");
        label1:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuiteCheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuiteCheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuiteCheckRequirementEnabledChecker(bool enabled) {
            this.Manager.Comment("checking step \'return CheckRequirementEnabled/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, enabled, "enabled of CheckRequirementEnabled, state S10");
        }
        
        private void MSOXCTABL_S03_BookmarkRops_Freebookmark_HierarchyTable_TestSuiteCheckRequirementEnabledChecker1(bool enabled) {
            this.Manager.Comment("checking step \'return CheckRequirementEnabled/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, enabled, "enabled of CheckRequirementEnabled, state S10");
        }
        #endregion
    }
}
