Jabber-Net source code licensing
================================

Jabber-Net
----------

The core source code is licensed under the terms of LGPLv3 license, see
[licenses/Jabber-Net_LGPLv3.txt][jabber-net] for details.

It's copyrighted by Cursive Systems, Inc. in 2002—2008; from 2008 it was altered
by some independent contributors and it's safe to assume that these
contributions are copyrighted by them.

Original author (Joe Hildebrand) asked the library users to don't make a
commercial XMPP servers using the library, but unambigiously put no legal
restrictions on that.

LGPLv3 is the main license for the project; all the new contributions are
licensed under the terms of this license.

### History

Previous versions of Jabber-Net at various times were available under the terms
of [Jabber Open Source License (JOSL)][josl] and [GPLv2][gplv2].

### Source tagging policy

Current project maintainers are not happy with explicitly naming the licenses in
headers of every source file (especially because there're some source code
formats that disallow such headers), so we state the following the policy
regarding the license headers ([like this][header-sample]):

1.  Leave the headers as-is on their places in the source code. They're just
    mentioning some facts that are known to be true (the code is indeed licensed
    by the mentioned authors in the mentioned years; the code is indeed licensed
    under the terms of the mentioned license/licenses; all the rights are
    definitely reserved).
2.  Change the license file names in the headers correspondingly when moving the
    license files (so the reader won't be confused if the license files are
    moved).
3.  Do not change the headers in any way: don't add any additional copyright
    notices (they aren't required to claim the copyright as a code author);
    don't change the copyright years.
4.  Don't add any headers in the new files; placing this `Licensing.md` file in
    the root of the source code package should be enough.

netlib.Dns
----------

[netlib.Dns][netlib-dns] project is copyrighted by "The ASP Emporium
(http://www.aspemporium.com/)" whose site is currently unavailable. We assume
that it has the same license as Jabber-Net itself, because its source code was
found in the same repository as Jabber-Net with no explicit license marks, so it
has to be covered by the [main Jabber-Net license file][jabber-net].

stringprep
----------

`stringprep` namespace contains some files based on the included GPL-licensed
Perl scripts copyrighted by Simon Josefsson, Tom Tromey, and Red Hat Software.

The scripts are:

- [`gen-stringprep-tables.pl`][gen-stringprep-tables-pl]
- [`gen-unicode-tables.pl`][gen-unicode-tables-pl]

The output of these generators is explicitly mentioned as unrestricted, so we're
distributing it (and not the scripts themselves) as an integral part of
Jabber-Net under the terms of LGPL.

UNICODE
-------

Portions of [stringprep.unicode][stringprep-unicode] namespace contains data
published by UNICODE, INC. under the terms of [UNICODE, INC. LICENSE
AGREEMENT][unicode].

UnixDnsResolver
---------------

[`UnixDnsResolver`][unixdnsresolver] class is licensed by Eric Butler in 2008
under the terms of the [Simplified BSD License][unixdnsresolver-license].

xpnet
-----

[xpnet][] namespace is currently an integral part of Jabber-Net. It's
copyrighted by its author in 1997 and 1998 under the terms of modified MIT
license. See the full license text at [licenses/xpnet_MIT.txt][xpnet-mit].

[gen-stringprep-tables-pl]: src/JabberNet/stringprep/steps/gen-stringprep-tables.pl
[gen-unicode-tables-pl]: src/JabberNet/stringprep/unicode/gen-unicode-tables.pl
[jabber-net]: licenses/Jabber-Net_LGPLv3.txt
[unicode]: licenses/UNICODE.txt
[unixdnsresolver-license]: licenses/UnixDnsResolver_BSD.txt
[xpnet-mit]: licenses/xpnet_MIT.txt

[bedrock-net-certutil]: https://github.com/ForNeVeR/Jabber-Net/blob/develop/bedrock/net/CertUtil.cs
[gplv2]: http://www.fsf.org/licensing/licenses/info/GPLv2.html
[header-sample]: https://github.com/ForNeVeR/Jabber-Net/blob/71e48fbaf4e4408e44734861c8ce1d436aeee2a4/JabberNet.ConsoleClient/Main.cs#L1-L13
[josl]: http://archive.jabber.org/core/JOSL.pdf
[netlib-dns]: https://github.com/ForNeVeR/Jabber-Net/tree/develop/netlib.Dns
[stringprep-unicode]: https://github.com/ForNeVeR/Jabber-Net/tree/41059bb1d70b678b17bf494e71a4a08e2f3b42e1/src/JabberNet/stringprep/unicode
[unixdnsresolver]: https://github.com/ForNeVeR/Jabber-Net/blob/41059bb1d70b678b17bf494e71a4a08e2f3b42e1/src/JabberNet/bedrock/net/UnixDnsResolver.cs
[xpnet]: https://github.com/ForNeVeR/Jabber-Net/tree/develop/xpnet
