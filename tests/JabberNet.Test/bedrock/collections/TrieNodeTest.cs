/* --------------------------------------------------------------------------
 * Copyrights
 *
 * Portions created by or assigned to Cursive Systems, Inc. are
 * Copyright (c) 2002-2008 Cursive Systems, Inc.  All Rights Reserved.  Contact
 * information for Cursive Systems, Inc. is available at
 * http://www.cursive.net/.
 *
 * License
 *
 * Jabber-Net is licensed under the LGPL.
 * See licenses/Jabber-Net_LGPLv3.txt for details.
 * --------------------------------------------------------------------------*/

using JabberNet.bedrock.collections;
using NUnit.Framework;

namespace JabberNet.Test.bedrock.collections
{
    /// <summary>
    ///    Summary description for TemplateTest.
    /// </summary>
    [TestFixture]
    public class TrieNodeTest
    {
        [Test] public void Test_Main()
        {
            System.Text.Encoding ENC = System.Text.Encoding.Default;
            TrieNode n = new TrieNode(null, 0);
            byte[] key = ENC.GetBytes("test");
            TrieNode current = n;
            for (int i=0; i<key.Length; i++)
            {
                byte b = key[i];
                current = current[b, true];
            }
            current.Value = "foo";
            Assert.AreEqual(ENC.GetString(key), ENC.GetString(current.Key));
        }
    }
}