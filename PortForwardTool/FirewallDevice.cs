using System;
using System.Collections.Generic;
using System.Security.Policy;
using NetFwTypeLib;

namespace PortForwardTool
{
    class FirewallDevice
    {
        readonly INetFwPolicy2 firewallPolicy;
        List<INetFwRule> createdRules = new List<INetFwRule>();
        readonly Dictionary<int, INetFwRule> createdRules2 = new Dictionary<int, INetFwRule>();

        public FirewallDevice()
        {
            firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(
                    Type.GetTypeFromProgID("HNetCfg.FwPolicy2")
                );
        }

        public void AllowPort(int port)
        {
            if(createdRules2.ContainsKey(port)) return;
            
            INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(
                    Type.GetTypeFromProgID("HNetCfg.FWRule")
                );
            firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            firewallRule.Description = "Rule created by the portforwarding tool. Allows traffic on port " + port.ToString();
            firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            firewallRule.Enabled = true;
            firewallRule.InterfaceTypes = "All";
            firewallRule.Name = "_Opened port " + port.ToString() + " by portforwarding tool";
            firewallRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
            firewallRule.RemotePorts = port.ToString();
            firewallRule.LocalPorts = port.ToString();

            firewallPolicy.Rules.Add(firewallRule);
            createdRules2[port] = firewallRule;
        }

        public void RemoveRule(int port)
        {
            if (!createdRules2.ContainsKey(port)) return;
            INetFwRule rule = createdRules2[port];
            firewallPolicy.Rules.Remove(rule.Name);
            createdRules2.Remove(port);
        }

        ~FirewallDevice()
        {
            foreach(int port in createdRules2.Keys)
            {
                RemoveRule(port);
            }
        }

    }
}
